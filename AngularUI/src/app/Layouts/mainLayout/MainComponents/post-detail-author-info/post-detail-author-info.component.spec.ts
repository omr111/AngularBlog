import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PostDetailAuthorInfoComponent } from './post-detail-author-info.component';

describe('PostDetailAuthorInfoComponent', () => {
  let component: PostDetailAuthorInfoComponent;
  let fixture: ComponentFixture<PostDetailAuthorInfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostDetailAuthorInfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostDetailAuthorInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
