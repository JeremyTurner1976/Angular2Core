import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { HomeRoutes } from './home.routes';
import { HomeComponent } from './components/home.component';

import { MdButtonModule } from '@angular/material';

@NgModule({
	imports: [
		CommonModule,
		FormsModule,
		HttpModule,
		HomeRoutes,
		MdButtonModule
	],

	declarations: [
		HomeComponent
	],

	exports: [
		HomeComponent
	]
})

export class HomeModule { }