import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { MainLayoutComponent } from "./Layouts//mainLayout/main-layout/main-layout.component";
import { AdminLayoutComponent } from "./Layouts//adminLayout/admin-layout/admin-layout.component";

import { HomePageComponent } from "./Layouts//mainLayout/MainViews/home-page/home-page.component";
import { ContactComponent } from "./Layouts//mainLayout/MainViews/contact/contact.component";
import { AboutUsComponent } from "./Layouts//mainLayout/MainViews/about-us/about-us.component";
import { SinglePostComponent } from "./Layouts//mainLayout/MainViews/single-post/single-post.component";
import { ListpostBycategoryComponent } from './MainViews/listpost-bycategory/listpost-bycategory.component';
const routes: Routes = [
  {
    path: "",
    component: MainLayoutComponent,
    children: [
     
      {
        path: "",
        component: HomePageComponent,
      },
      {
        path: "iletisim",
        component: ContactComponent,
      },
      {
        path: "hakkimizda",
        component: AboutUsComponent,
      },
      {
        path:"sayfa/:pageNumber",
        component:HomePageComponent
      },
      {
        path:"makale/:title/:id",
        component:SinglePostComponent
      },
      {
        path:"kategori/:categoryName/:categoryId",
        component:ListpostBycategoryComponent
      },
      {
        path:"kategori/:categoryName/:categoryId/sayfa/:page",
        component:ListpostBycategoryComponent
      }
    
    ],
  },
  {
    path:"admin",
    component:AdminLayoutComponent,
    
    
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
