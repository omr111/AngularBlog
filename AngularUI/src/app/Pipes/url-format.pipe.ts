import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'urlFormat'
})
export class UrlFormatPipe implements PipeTransform {

  transform(value: any, ...args: any[]): any {
    value.toLowerCase();
    value=value.replace(/[.,"*+?^${}()|[\]\\]/g,"-");
    value=value.replace(/\s/g,"-");
    value=value.replace(/[ç]/g,"c");
    value=value.replace(/[ğ]/g,"g");
    value=value.replace(/[ü]/g,"u");
    value=value.replace(/[ö]/g,"o");
    value=value.replace(/[ı]/g,"i");
    value=value.replace(/[ş]/g,"s"); 
    value=value.replace(/[#]/g,"sharp");
    return value;
  }

}
