import { Component, ElementRef, EventEmitter, Injector, Output, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { ServiceDto, ServiceServiceProxy } from '@shared/service-proxies/service-proxies';
import { ModalDirective } from 'ngx-bootstrap';
import { finalize } from 'rxjs/operators';

@Component({
    selector: 'edit-service-modal',
    templateUrl: './edit-service.component.html'
})
export class EditServiceComponent extends AppComponentBase {

    @ViewChild('editServiceModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;
    service: ServiceDto = null;

    constructor(
        injector: Injector,
        private _serviceService: ServiceServiceProxy
    ) {
        super(injector);
    }

    show(id: number): void {
        this._serviceService.get(id)
            .pipe(finalize(() => {
                this.active = true;
                this.modal.show();
            }))
            .subscribe((result: ServiceDto) => {
                this.service = result;
            });
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        this.saving = true;
        this._serviceService.update(this.service)
            .pipe(finalize(() => { this.saving = false; }))
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
