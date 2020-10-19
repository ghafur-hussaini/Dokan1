import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InventoryService {

  constructor(private http:HttpClient) { }
  url='/api/inventory';
  public GetInventory (){
    return this.http.get(this.url);
  }
}
