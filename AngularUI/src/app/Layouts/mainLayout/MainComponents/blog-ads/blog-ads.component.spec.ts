import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BlogAdsComponent } from './blog-ads.component';

describe('BlogAdsComponent', () => {
  let component: BlogAdsComponent;
  let fixture: ComponentFixture<BlogAdsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BlogAdsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BlogAdsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
