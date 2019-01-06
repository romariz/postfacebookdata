import { AbpModule } from '@abp/abp.module';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { JsonpModule } from '@angular/http';
import { AboutComponent } from '@app/about/about.component';
import { HomeComponent } from '@app/home/home.component';
import { RightSideBarComponent } from '@app/layout/right-sidebar.component';
import { SideBarFooterComponent } from '@app/layout/sidebar-footer.component';
import { SideBarNavComponent } from '@app/layout/sidebar-nav.component';
import { SideBarUserAreaComponent } from '@app/layout/sidebar-user-area.component';
import { TopBarLanguageSwitchComponent } from '@app/layout/topbar-languageswitch.component';
import { TopBarComponent } from '@app/layout/topbar.component';
import { CreateRoleComponent } from '@app/roles/create-role/create-role.component';
import { RolesComponent } from '@app/roles/roles.component';
import { ServicesComponent } from '@app/services/services.component';
import { TenantsComponent } from '@app/tenants/tenants.component';
import { CreateUserComponent } from '@app/users/create-user/create-user.component';
import { UsersComponent } from '@app/users/users.component';
import { SharedModule } from '@shared/shared.module';
import { ModalModule } from 'ngx-bootstrap';
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EditRoleComponent } from './roles/edit-role/edit-role.component';
import { CreateServiceComponent } from './services/create-service/create-service.component';
import { EditServiceComponent } from './services/edit-service/edit-service.component';
import { CreateTenantComponent } from './tenants/create-tenant/create-tenant.component';
import { EditTenantComponent } from './tenants/edit-tenant/edit-tenant.component';
import { EditUserComponent } from './users/edit-user/edit-user.component';

// console.assert(CreateServiceComponent, "Uhoh, CreateServiceComponent was not defined, likely part of a circular reference loop");
// console.assert(EditServiceComponent, "Uhoh, EditServiceComponent was not defined, likely part of a circular reference loop");
@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        AboutComponent,
        TenantsComponent,
        ServicesComponent,
        CreateTenantComponent,
        EditTenantComponent,
        CreateServiceComponent,
        EditServiceComponent,
        UsersComponent,
        CreateUserComponent,
        EditUserComponent,
        RolesComponent,
        CreateRoleComponent,
        EditRoleComponent,
        TopBarComponent,
        TopBarLanguageSwitchComponent,
        SideBarUserAreaComponent,
        SideBarNavComponent,
        SideBarFooterComponent,
        RightSideBarComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        JsonpModule,
        ModalModule.forRoot(),
        AbpModule,
        AppRoutingModule,
        SharedModule,
        NgxPaginationModule
    ],
    providers: [

    ]
})
export class AppModule { }
