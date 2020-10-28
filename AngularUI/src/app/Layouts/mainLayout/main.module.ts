import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { BrowserModule } from "@angular/platform-browser";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { AppRoutingModule } from "../../app-routing.module";

import { HomePageComponent } from "./MainViews/home-page/home-page.component";
import { ContactComponent } from "./MainViews/contact/contact.component";
import { AboutUsComponent } from "./MainViews/about-us/about-us.component";
import { SinglePostComponent } from "./MainViews/single-post/single-post.component";

import { PostListComponent } from "./MainComponents/post-list/post-list.component";
import { CategoriesComponent } from "./MainComponents/categories/categories.component";
import { PopularListComponent } from "./MainComponents/popular-list/popular-list.component";
import { LastAddedComponent } from "./MainComponents/last-added/last-added.component";

import { PostDetailAuthorInfoComponent } from "./MainComponents/post-detail-author-info/post-detail-author-info.component";
import { BlogAdsComponent } from "./MainComponents/blog-ads/blog-ads.component";
import { FooterComponent } from "./MainComponents/footer/footer.component";
import { MainLayoutComponent } from "./main-layout/main-layout.component";
import {NgxPaginationModule} from "ngx-pagination";

import { LogoPanelComponent } from "./MainComponents/logo-panel/logo-panel.component";
import { NavigationComponent } from "./MainComponents/navigation/navigation.component";
import { TopSearchMenuComponent } from "./MainComponents/top-search-menu/top-search-menu.component";
import { SliderComponent } from "./MainComponents/slider/slider.component";
import { InstagramSharedSliderComponent } from "./MainComponents/instagram-shared-slider/instagram-shared-slider.component";
import { NavigationGroupComponent } from "./MainComponents/navigation-group/navigation-group.component";
import { PostTagsComponent } from "./MainComponents/post-tags/post-tags.component";
import { HttpClientModule } from '@angular/common/http';
import { UrlFormatPipe } from 'src/app/Pipes/url-format.pipe';
import { ListpostBycategoryComponent } from './MainViews/listpost-bycategory/listpost-bycategory.component';



@NgModule({
  declarations: [
    MainLayoutComponent,
    HomePageComponent,
    ContactComponent,
    AboutUsComponent,
    PostListComponent,
    CategoriesComponent,
    PopularListComponent,
    LastAddedComponent,
    PostDetailAuthorInfoComponent,
    BlogAdsComponent,
    FooterComponent,
    SinglePostComponent,
    PostTagsComponent,
    LogoPanelComponent,
    NavigationComponent,
    TopSearchMenuComponent,
    SliderComponent,
    InstagramSharedSliderComponent,
    NavigationGroupComponent,
    UrlFormatPipe,
    ListpostBycategoryComponent,
    
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    NgxPaginationModule
  ],
  exports:[
    UrlFormatPipe
  ]
})
export class MainModule {}
