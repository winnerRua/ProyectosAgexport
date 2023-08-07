import { Component } from '@angular/core';
import { Colaborador } from './models/colaborador';
import { ColaboradorService } from './services/colaborador.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  colaborador:Colaborador = new Colaborador();
  datatable:any = [];

  constructor(private colaboradorService:ColaboradorService){

  }

  ngOnInit(): void{
    this.onDataTable();
  }

  onDataTable(){
    this.colaboradorService.getColaborador().subscribe(res => {
      this.datatable = res;
      console.log(res);
    });
  }

  onAddColaborador(colaborador:Colaborador):void{
    this.colaboradorService.addColaborador(colaborador).subscribe(res => {
      if(res){
        alert(`El colaborador ${colaborador.nombres} se ha registrado con éxito!`);
        this.clear();
        this.onDataTable();
      }
      else{
        alert(`Error al registrar!`)
      }
    });
  }

  onUpdateColaborador(colaborador:Colaborador):void{
    this.colaboradorService.updateColaborador(colaborador.colaboradorId, colaborador).subscribe(res => {
      if(res){
        alert(`El colaborador número ${colaborador.colaboradorId} se ha modificado con éxito!`);
        this.clear();
        this.onDataTable();
      } else {
        alert('Error! :(')
      }
    });
  }

  onDeleteColaborador(id:number):void{
    this.colaboradorService.deleteColaborador(id).subscribe(res => {
      if(res){
        alert(`El colaborador número ${id} se ha eliminado con exito!`);
        this.clear();
        this.onDataTable();
      } else {
        alert('Error! :(')
      }
    });
  }

  onSetData(select:any){
    this.colaborador.colaboradorId= select.ColaboradorId;
    this.colaborador.nombres = select.nombres;
    this.colaborador.apellidos = select.apellidos;
    this.colaborador.genero = select.genero;
    this.colaborador.estadoCivil = select.estadoCivil;
    this.colaborador.fechaNacimiento = select.fechaNacimiento;
    this.colaborador.edad = select.edad;
    this.colaborador.dpi = select.dpi;
    this.colaborador.igss = select.igss;
    this.colaborador.irtra = select.irtra;
    this.colaborador.pasaporte = select.pasaporte;
    this.colaborador.departamento = select.departamento;
    this.colaborador.municipio = select.municipio;
    this.colaborador.direccionResidencia = select.direccionResidencia;
  }

  clear(){
    this.colaborador.colaboradorId = 0;
    this.colaborador.nombres = "";
    this.colaborador.apellidos = "";
    this.colaborador.genero = "";
    this.colaborador.estadoCivil = "";
    this.colaborador.fechaNacimiento = new Date();
    this.colaborador.edad = 0;
    this.colaborador.dpi = 0;
    this.colaborador.igss = 0;
    this.colaborador.irtra = 0;
    this.colaborador.pasaporte = "";
    this.colaborador.departamento = "";
    this.colaborador.municipio = "";
    this.colaborador.direccionResidencia = "";
  }
}
