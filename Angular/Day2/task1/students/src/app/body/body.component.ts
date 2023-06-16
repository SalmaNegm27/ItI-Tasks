import { Component } from '@angular/core';


@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent {

 
  studentname: string = "";
  studentage: number=0;
  i : number = 1
  isStudentNameValid(): boolean {
    return this.studentname.length >= 3;
  }
  isStudentAgeValid(): boolean {
    return this.studentage > 18;
  }
 studentlist :{studentname: string , studentage:number}[] =[]
 add()
 {
  if(this.isStudentNameValid() && this.isStudentAgeValid())
  {
    let studentobj = {
      studentname : this.studentname,
      studentage : this.studentage
    };
  
    this.studentlist.push(studentobj)
    this.i ++;
  }
  
 }
}
