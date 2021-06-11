import { ICadastroFormulario } from './../models/ICadastroFormulario';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CursosService {

  constructor() { }

  getComboEstadoCivil(){
    let comboEstadoCivil: string[] = ['Solteiro(a)', 'Casado(a)', 'Viúvo(a)', 'Divorciado(a)']
    return comboEstadoCivil
  }

  // getGrid(){
  //   return dados
  // }
 
}
