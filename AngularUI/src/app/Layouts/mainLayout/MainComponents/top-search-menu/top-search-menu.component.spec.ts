import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopSearchMenuComponent } from './top-search-menu.component';

describe('TopSearchMenuComponent', () => {
  let component: TopSearchMenuComponent;
  let fixture: ComponentFixture<TopSearchMenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopSearchMenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopSearchMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
