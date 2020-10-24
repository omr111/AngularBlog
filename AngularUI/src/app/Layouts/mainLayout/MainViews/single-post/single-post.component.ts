import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";


import { SinglePost } from 'src/app/Models/single-post';
import { PostService } from "src/app/Services/post.service";

@Component({
  selector: "app-single-post",
  templateUrl: "./single-post.component.html",
  styleUrls: ["./single-post.component.css"],
})
export class SinglePostComponent implements OnInit {
  constructor(
    private postService: PostService,
    private activatedRoute: ActivatedRoute
  ) {}
  ajax: any;
  singlePost:SinglePost;

  
  ngOnInit() {
    
    
    this.activatedRoute.paramMap.subscribe((params) => {
      if(this.ajax!=null) this.ajax.unsubscribe();
      if (params.get("id")) {
        var id = Number(params.get("id"));
        this.postService.loading=true;
      }
      this.ajax=this.postService.getSinglePost(id).subscribe(x=>{
        this.singlePost=x;
     
      })

    });
   
  }
}
