import { Component, Input, OnInit } from "@angular/core";
import { Router, ActivatedRoute } from "@angular/router";
import { Post } from "src/app/Models/post";
import { PostService } from "src/app/Services/post.service";

@Component({
  selector: "app-post-list",
  templateUrl: "./post-list.component.html",
  styleUrls: ["./post-list.component.css"],
})
export class PostListComponent implements OnInit {
  constructor(private router: Router, private activateRoute: ActivatedRoute) {}
  @Input() pageNumber: number;
  @Input() posts: Post[];
  @Input() totalPostCount: number;
  @Input() perPageItemCount: number;
  categoryId: number;
  categoryName: string;
  @Input() typeOfPage;

  ngOnInit() {}

  pageChanged(event: number) {
    if (this.activateRoute.snapshot.paramMap.get("categoryId"))
      this.categoryId = Number(
        this.activateRoute.snapshot.paramMap.get("categoryId")
      );
    if (this.activateRoute.snapshot.paramMap.get("categoryName"))
      this.categoryName = this.activateRoute.snapshot.paramMap.get(
        "categoryName"
      );
    this.pageNumber = event;
    switch (this.typeOfPage) {
      case "listPostByCategory":
        this.router.navigateByUrl(
          `/kategori/${this.categoryName}/${this.categoryId}/sayfa/${this.pageNumber}`
        );
        break;
      case "noneFilteredPostList":
        this.router.navigateByUrl(`/sayfa/${this.pageNumber}`);
        break;
      case "searchedPostList":
        let searchText=this.activateRoute.snapshot.queryParamMap.get("s");
        this.router.navigateByUrl(`/arama/sayfa/${this.pageNumber}?s=${searchText}`);
        break;
      default:
        this.router.navigateByUrl(`/sayfa/${this.pageNumber}`);
        break;
    }
  }
}
