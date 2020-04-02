import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ServersComponent } from './servers/servers.component';
import { DashboardComponent } from './dashboard/dashboard.component';



@NgModule({
  declarations: [ServersComponent, DashboardComponent],
  imports: [
    CommonModule
  ]
})
export class ServerStatusDashboardModuleModule { }
