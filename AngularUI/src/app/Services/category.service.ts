import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Category} from '../Models/category';
@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private client:HttpClient) {

   }
   private apiUrl="https://localhost:44319/api/categories";
   public getAllCategories(){
     return this.client.get<Category[]>(this.apiUrl);
   }
   public getOneCategory(id:number)  {
     var newUrl=`${this.apiUrl}/${id}`;
     return this.client.get<Category>(newUrl);
   }
}
