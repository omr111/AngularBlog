import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Post } from "src/app/Models/post";
import { PostService } from "src/app/Services/post.service";

@Component({
  selector: "app-listpost-bycategory",
  templateUrl: "./listpost-bycategory.component.html",
  styleUrls: ["./listpost-bycategory.component.css"],
})
export class ListpostBycategoryComponent implements OnInit {
  constructor(
    private postService: PostService,
    private activateRoute: ActivatedRoute,

  ) {}
  posts: Post[];
  totalPostCount: number;
  page: number = 1;
  perPageItemCount: number = 2;
  categoryId: number;
  typeOfPage:string;
  ajax: any;
  categoryName:string;

  ngOnInit() {
    if (this.ajax != null) {
      this.ajax.unsubscribe();
    }
    this.activateRoute.paramMap.subscribe((params) => {
      if (params.get("page")) {
        this.page = Number(params.get("page"));
      }
      if (params.get("categoryId")) {
     
        this.categoryId = Number(params.get("categoryId"));
      }
      if(params.get("categoryName")){
        this.categoryName=params.get("categoryName");
      }
      this.ajax = this.postService
        .getPostListByCategoryId(
          this.categoryId,
          this.perPageItemCount,
          this.page
        )
        .subscribe((data) => {
          this.posts = data.posts;
          this.totalPostCount = data.totalPostCount;
        });
    });
  }
}
