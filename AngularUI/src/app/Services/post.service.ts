import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { PostPg } from "../Models/post-pg";
import { tap } from "rxjs/Operators";
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
}
