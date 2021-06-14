
import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ICadastroFormulario } from './models/ICadastroFormulario';
import { CursosService } from './services/cursos.service';

interface ComboEstadoCivil {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-cursos',
  templateUrl: './cursos.component.html',
  styleUrls: ['./cursos.component.scss']
})
export class CursosComponent implements OnInit {
  public title: string = 'Formulário de Cadastro';
  public listagem: string = 'Listagem Formulário'

  public botaoAdicionarIdade: string ='Adicionar Idade';
  public botaoRemoverIdade: string ='Remover Idade';
  public selectedValue: string;

  valoresIdade: number[] = [1]
  public indexIdade: number = 0;
  public valorMeses: any = 0;

  public DadosGrid: ICadastroFormulario[];

  constructor(private cursosService: CursosService ) 
  { }

  estadosCivis: ComboEstadoCivil[] = [
    {value: '0', viewValue: 'Solteiro'},
    {value: '1', viewValue: 'Casado'},
    {value: '2', viewValue: 'Viuvo'},
    {value: '3', viewValue: 'Divorciado'}
  ];
  
  ngOnInit(): void {}
  
  incrementoIdade(){
    var proximoIndex = this.indexIdade + 1
    if(this.valoresIdade.length > proximoIndex){
      this.indexIdade++
    }else{
      var proximaIdade = this.valoresIdade[this.indexIdade]+1
      this.valoresIdade.push(proximaIdade);
      this.indexIdade++
    }
  }

  decrementoIdade(){
    if(this.valoresIdade.length > 1){
      this.valoresIdade.splice(this.indexIdade, 1);
      this.indexIdade--
    }
  }

  comboStatoCivil(){
    this.cursosService.getComboEstadoCivil()
  }

  configuraDadosGrid(){
    this.DadosGrid
   
    
    
  }
  
}
