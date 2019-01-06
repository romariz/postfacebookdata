import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
    PagedResultDtoOfServiceDto,
    ServiceDto,
    ServiceEnum,
    ServiceServiceProxy,
} from '@shared/service-proxies/service-proxies';
import { CreateServiceComponent } from 'app/services/create-service/create-service.component';
import { EditServiceComponent } from 'app/services/edit-service/edit-service.component';
import { finalize } from 'rxjs/operators';
import { PagedListingComponentBase, PagedRequestDto } from 'shared/paged-listing-component-base';

@Component({
    templateUrl: './services.component.html',
    animations: [appModuleAnimation()]
})
export class ServicesComponent extends PagedListingComponentBase<ServiceDto> {

    @ViewChild('createServiceModal') createServiceModal: CreateServiceComponent;
    @ViewChild('editServiceModal') editServiceModal: EditServiceComponent;

    services: ServiceDto[] = [];

    constructor(
        injector: Injector,
        private _serviceService: ServiceServiceProxy
    ) {
        super(injector);
    }

    list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        this._serviceService.getAll(request.skipCount, request.maxResultCount)
            .pipe(finalize(() => { finishedCallback() }))
            .subscribe((result: PagedResultDtoOfServiceDto) => {
                this.services = result.items;
                this.showPaging(result, pageNumber);
            });
    }

    delete(service: ServiceDto): void {
        abp.message.confirm(
            "Delete service '" + this.getServiceName(service.serviceType) + "'?",
            (result: boolean) => {
                if (result) {
                    this._serviceService.delete(service.id)
                        .pipe(finalize(() => {
                            abp.notify.info("Deleted service: " + this.getServiceName(service.serviceType));
                            this.refresh();
                        }))
                        .subscribe(() => { });
                }
            }
        );
    }

    // Show modals
    createService(): void {
        this.createServiceModal.show();
    }

    editService(service: ServiceDto): void {
        this.editServiceModal.show(service.id);
    }

    getServiceName(serviceType: ServiceEnum) {
        var result = '';
        switch (serviceType) {
            case 1:
                {
                    result = "Ghost";
                    break;
                }
        }
        return result;
    }
}
