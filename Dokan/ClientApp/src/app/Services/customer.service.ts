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
  public pushBalance(id,newBalance){
    return this.http.put(this.url + "/" + id , newBalance);
  }
}
