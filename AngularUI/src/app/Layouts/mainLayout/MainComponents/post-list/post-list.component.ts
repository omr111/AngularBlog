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
  constructor(
  
    private router: Router,
  
  ) {}
  @Input() pageNumber: number;
  @Input() posts: Post[];
  @Input() totalPostCount: number;
  @Input() perPageItemCount: number;
  @Input() categoryId:number;
  @Input() categoryName:string;
  @Input() typeOfPage;
  
  ngOnInit() {
   
  }

 
  pageChanged(event:number){
    this.pageNumber=event;
    switch (this.typeOfPage) {
      case "listPostByCategory":
        this.router.navigateByUrl(`/kategori/${this.categoryName}/${this.categoryId}/sayfa/${this.pageNumber}`);
        break;
        case "noneFilteredPostList":
          this.router.navigateByUrl(`/sayfa/${this.pageNumber}`);
          break;
     
      default: this.router.navigateByUrl(`/kategori/${this.categoryName}/${this.categoryId}/sayfa/${this.pageNumber}`);
        break;
    }

    
  
   
    
  }
}
