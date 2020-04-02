import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent } from './server-status-dashboard-module/dashboard/dashboard.component';
import { AppComponent } from './app.component';

const routes: Routes = [
  { path: 'server-status-dashboard', component: DashboardComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
