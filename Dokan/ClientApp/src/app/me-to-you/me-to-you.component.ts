import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../Services/customer.service';
import { PhoneService } from '../Services/phone.service';
import { MeToYouService } from '../Services/me-to-you.service';

@Component({
  selector: 'app-me-to-you',
  templateUrl: './me-to-you.component.html',
  styleUrls: ['./me-to-you.component.css']
})
export class MeToYouComponent implements OnInit {
 customers:any;
 customersArr:any[];
 Phones;
 phone;
 PhonesArr:any[];
 customer;
 today:number= Date.now();
 selectedCustomer;
 selectedPhones:{}[];
 remain;

  constructor(private customerService:CustomerService,private phoneservice:PhoneService,private mtyService:MeToYouService) { }

  ngOnInit() {
 this.customerService.getCustomer().subscribe( res =>{
  this.customers =res; 
   console.log(this.customers);
  });

  }
  onCalculateBalance(cash,amoung,phone,date){
    this.remain = parseInt(amoung)+this.selectedCustomer.balance-parseInt(cash);
      let newRecord ={
      date:date,
      customerName:this.selectedCustomer.customerName,
      phoneNumber:parseInt(phone),
      amounf:parseInt(amoung),
      cash:parseInt(cash),
      balance:parseInt(this.remain)
    }
    // console.log(newRecord);
    this.mtyService.MtyAddRecord(newRecord).subscribe(res =>
      console.log(res));
    }
 onChangeCustomer(){
   this.customersArr = this.customers;
  this.selectedCustomer =this.customersArr.find( c => c.id === parseInt(this.customer));
    console.log(this.selectedCustomer);
    this.phoneservice.getPhone(this.selectedCustomer.id).subscribe(res =>{
      this.Phones=res;
      this.PhonesArr = this.Phones;
      console.log(this.PhonesArr);
     })
    
    }
   
   
 }
