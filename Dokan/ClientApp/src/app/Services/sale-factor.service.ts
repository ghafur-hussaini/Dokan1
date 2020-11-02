import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SaleFactorService {

  constructor(private http:HttpClient) { }
  url= "/api/salefactor";

  public CreateSellingFactor(factor){
    return this.http.post(this.url,factor);
  }
  public UpdateFactor(id:Int16Array,completeFactor)
  {
    return this.http.put(this.url + "/" + "id", completeFactor);
  }
}
