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
 MeToYouVendor;

  constructor(private customerService:CustomerService,private phoneservice:PhoneService,private mtyService:MeToYouService) { }

  ngOnInit() {
 this.customerService.getCustomer().subscribe( res =>{
  this.customers =res; 
  this.customersArr = this.customers;
   console.log(this.customers);
   this.MeToYouVendor = this.customersArr.find(c => c.id == 9);
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
 
  this.selectedCustomer =this.customersArr.find( c => c.id === parseInt(this.customer));
    console.log(this.selectedCustomer);
    this.phoneservice.getPhone(this.selectedCustomer.id).subscribe(res =>{
      this.Phones=res;
      this.PhonesArr = this.Phones;
      console.log(this.PhonesArr);
     })
    
    }
   ChangeBalance(balance){
     this.customerService.pushBalance(this.selectedCustomer.id, this.remain).subscribe( res =>{
       console.log(res);
      // console.log(balance);
     })
   }
   onCalculateBalance2(received,paid){
     console.log(this.MeToYouVendor.balance);
     this.MeToYouVendor.balance += (received- paid);
     console.log(this.MeToYouVendor.balance);
   }
   ChangeBalance2(){
    //  this.MeToYouVendor={
    //    id:this.MeToYouVendor.id,
    //    customerName:this.MeToYouVendor.customerName,
    //    balance:this.MeToYouVendor.balance,
    //    phones:[]

    //  }
     this.customerService.pushBalance(9,this.MeToYouVendor).subscribe(res =>
      console.log(res));
   }
 }
