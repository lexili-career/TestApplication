import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../../environments/environment'
//'@environments/environment';
import { User } from '../models';


const baseUrl = `${environment.apiUrl}/SampleData`;

@Injectable({ providedIn: 'root' })
export class UserService {
    constructor(private http: HttpClient) { }

    create(params: any) {
        
        return this.http.post(baseUrl, params);
    }

   
}