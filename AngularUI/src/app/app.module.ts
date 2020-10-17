import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import{AdminModuleModule} from './Layouts/adminLayout/admin-module.module';
import {MainModule} from './Layouts/mainLayout/main.module';


@NgModule({
  declarations: [
    AppComponent,
    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AdminModuleModule,
    MainModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
