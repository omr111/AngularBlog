import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Post } from 'src/app/Models/post';
import { PostService } from 'src/app/Services/post.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  pageNumber: number = 1;
  posts: Post[];
  totalPostCount: number;
  perPageItemCount: number = 2;
  typeOfPage:string;
  ajax:any;
  loading :boolean;
  constructor(  private postService: PostService,  private activeRoute: ActivatedRoute) { }

  ngOnInit() {
   
    this.activeRoute.paramMap.subscribe(params => {

      if(this.ajax!=null) this.ajax.unsubscribe();
      if (params.get("pageNumber")) {
  
        this.pageNumber = Number(params.get("pageNumber"));
      }
     
      this.posts = [];
      this.totalPostCount = 0;
    this.ajax= this.postService.getPostList(this.perPageItemCount, this.pageNumber).subscribe(data => {
      this.loading=this.postService.loading;
        this.posts = data.posts;
          this.totalPostCount = data.totalPostCount;
     
        });
    });
  }

}
