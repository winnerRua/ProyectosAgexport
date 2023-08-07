import { Time } from "@angular/common";

export class Colaborador {
    colaboradorId:number = 0;
    nombres:string = "";
    apellidos:string = "";
    genero:string = "";
    estadoCivil:string = "";
    fechaNacimiento:Date = new Date();
    edad:number = 0;
    dpi:number = 0;
    igss:number = 0;
    irtra:number = 0;
    pasaporte:string = "";
    departamento:string = "";
    municipio:string = "";
    direccionResidencia:string = "";
}