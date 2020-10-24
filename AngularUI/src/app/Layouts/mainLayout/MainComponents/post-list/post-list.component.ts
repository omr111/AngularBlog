import { Component, OnInit } from "@angular/core";
import { Router, ActivatedRoute } from "@angular/router";
import { Post } from "src/app/Models/post";
import { PostService } from "src/app/Services/post.service";

@Component({
  selector: "app-post-list",
  templateUrl: "./post-list.component.html",
  styleUrls: ["./post-list.component.css"],
})
export class PostListComponent implements OnInit {
  constructor(
    private postService: PostService,
    private router: Router,
    private activeRoute: ActivatedRoute
  ) {}
  pageNumber: number = 1;
  posts: Post[];
  totalPostCount: number;
  pageCount: number = 2;
  ajax:any;

  ngOnInit() {
    this.activeRoute.paramMap.subscribe(params => {

      if(this.ajax!=null) this.ajax.unsubscribe();
      if (params.get("pageNumber")) {
        this.pageNumber = Number(params.get("pageNumber"));
      }
     
      this.posts = [];
      this.totalPostCount = 0;
    this.ajax= this.postService.getPostList(this.pageCount, this.pageNumber).subscribe(data => {
        
        this.posts = data.posts;
          this.totalPostCount = data.totalPostCount;
     
        });
    });
  }

  pageChanged(event:number){
    this.pageNumber=event;
    this.router.navigateByUrl(`/sayfa/${this.pageNumber}`);
   
  }
}
