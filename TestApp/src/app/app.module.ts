import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SaveDataComponent } from './save-data/save-data.component';
import { CommonModule } from '@angular/common';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';


const appRoutes: Routes = [
  {
      path: '',
     // redirectTo: '/sample',
      pathMatch: 'full',
      component: SaveDataComponent
  }  
 
  ];

@NgModule({
  declarations: [
    AppComponent,
    SaveDataComponent,
    //ReactiveFormsModule,
    //CommonModule
  ],
  imports: [
    BrowserModule,
   // RouterModule.forRoot(appRoutes),
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    CommonModule,
    HttpClientModule
  ],
  exports: [ RouterModule ],
  
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
