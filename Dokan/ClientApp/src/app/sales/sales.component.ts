import { Component, OnInit } from '@angular/core';
import { InventoryService } from '../Services/inventory.service';

import { HttpClient } from '@angular/common/http';
import { SellingBillService } from '../Services/selling-bill.service';
import { SaleFactorService } from '../Services/sale-factor.service';
import { CustomerService } from '../Services/customer.service';

@Component({
  selector: 'app-sales',
  templateUrl: './sales.component.html',
  styleUrls: ['./sales.component.css']
})
export class SalesComponent implements OnInit {
  Stuffs ;
  stuffs : any[];
  number = [1,2,3,4,5,6,7,8,9];
  selectedStuff;
  Qty;
  Sum;
  bill :any;
  Factor;
  today= Date.now().toString();


  constructor(private stuffService :InventoryService,private SService:SellingBillService,private saleFactor: SaleFactorService,private customerService:CustomerService ) { }

  ngOnInit() {
    this.stuffService.GetInventory().subscribe(res => {
      this.Stuffs = res;
      this.stuffs = this.Stuffs;
      console.log(res);
  });
   }
   onStuffChange(item){
this.selectedStuff = this.stuffs.find(s => s.id == item.value );
console.log(this.selectedStuff);
this.Qty = new Array(this.selectedStuff.qty).fill(0).map((x,i)=>i+1);
 }
onCalculateSum(quantity,price){
 let q = parseInt(quantity);
 let p = parseInt(price);
 let sum = q*p;
 return sum;
}
 AddBill(quantity,price){
 this.bill={
   stuffName:this.selectedStuff.stuffName,
   qty:parseInt(quantity),
   price:parseInt(price),
   sum:this.onCalculateSum(quantity,price)
 };
 
this.SService.CreateSalesBill(this.bill).subscribe( res => console.log(res));
}
CreateSellingFactor(date,name){
 this.Factor={
   customerName:name,
   date:date,
   total:0,
   balance:0,
   cash:0,
   bill:[]
}
// console.log(date);
this.saleFactor.CreateSellingFactor(this.Factor).subscribe(res =>
 console.log(res));
}
getCustomers(){
  this.customerService.getCustomer().subscribe(res =>
    console.log(res));
}
  
}