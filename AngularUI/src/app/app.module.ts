import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import  {HttpClientModule} from '@angular/common/http';
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
    MainModule,
    HttpClientModule
  
  ],
  
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
