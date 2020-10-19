import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  url='/api/customer'
  constructor(private http:HttpClient) { }
  public getCustomer(){
   return this.http.get(this.url);
  }
}
