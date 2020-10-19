import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SellingBillService {

  constructor(private http:HttpClient) { }
  url='/api/sales';
  public CreateSalesBill(bill){
    return this.http.post(this.url,bill);
  }
}
