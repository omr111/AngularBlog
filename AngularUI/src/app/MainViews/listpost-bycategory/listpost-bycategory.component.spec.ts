import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListpostBycategoryComponent } from './listpost-bycategory.component';

describe('ListpostBycategoryComponent', () => {
  let component: ListpostBycategoryComponent;
  let fixture: ComponentFixture<ListpostBycategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListpostBycategoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListpostBycategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
