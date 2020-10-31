import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { PostPg } from "../Models/post-pg";
import { tap } from "rxjs/Operators";

import { SinglePost } from '../Models/single-post';

@Injectable({
  providedIn: "root",
})
export class PostService {
  constructor(private httpClient: HttpClient) {}
  private url = "https://localhost:44319/api/Posts";
  public loading: boolean = true;
  getPostList(pageCount: number, pageNo: number) {
    let newUrl = `${this.url}/${pageCount}/${pageNo}`;

   return this.httpClient.get<PostPg>(newUrl).pipe(
            tap((x) => {
              this.loading = false;
                 })
          );
  }
  getSinglePost(id:number){
    let newUrl=`${this.url}/${id}`;
    return this.httpClient.get<SinglePost>(newUrl).pipe(tap(x=>{
      this.loading=false;
    }));  
  }
  getPostListByCategoryId(id:number ,itemCount:number,page:number){
    let newUrl=`${this.url}/${id}/${itemCount}/${page}`;
    return this.httpClient.get<PostPg>(newUrl).pipe(tap(x=>{
      this.loading=false;
    }))
  }
  getSearchPost(searchText:string,perPageItemCount:number,pageNumber:number){
    let newUrl=`${this.url}/searchPosts/${searchText}/${perPageItemCount}/${pageNumber}`;
    return this.httpClient.get<PostPg>(newUrl).pipe(tap(x=>{
      this.loading=false;
    }))
  }
  IncreaseViewCount(id:number){
    let newUrl=`${this.url}/IncreaseViewedCount/${id}`;
    return this.httpClient.get(newUrl);
  }
}
