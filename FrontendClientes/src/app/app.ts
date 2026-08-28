import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ClienteService } from './cliente';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  template: `
    <div style="padding: 20px; font-family: Arial, sans-serif; background-color: #f8f9fa; min-height: 100vh;">
      <h2>Gestión de Clientes (Prueba Técnica Full Stack)</h2>

      <!-- Formulario para Insertar / Modificar -->
      <fieldset style="margin-bottom: 20px; padding: 15px; border-radius: 5px; border: 1px solid #ccc; background-color: white;">
        <legend><strong>{{ clienteForm.idtcliente === 0 ? 'Insertar Cliente' : 'Modificar Cliente' }}</strong></legend>
        <form (ngSubmit)="guardar()">
          <input type="text" [(ngModel)]="clienteForm.nombre" name="nombre" placeholder="Nombre" required style="margin-right: 10px; padding: 5px;">
          <input type="text" [(ngModel)]="clienteForm.apellido" name="apellido" placeholder="Apellido" required style="margin-right: 10px; padding: 5px;">
          <input type="text" [(ngModel)]="clienteForm.direccion" name="direccion" placeholder="Dirección" required style="margin-right: 10px; padding: 5px;">
          <input type="text" [(ngModel)]="clienteForm.telefono" name="telefono" placeholder="Teléfono" required style="margin-right: 10px; padding: 5px;">
          <input type="number" [(ngModel)]="clienteForm.numero_cuenta" name="numero_cuenta" placeholder="Numero_cuenta" required style="margin-right: 10px; padding: 5px; width: 70px;">
          
          <button type="submit" style="padding: 5px 15px; background-color: #28a745; color: white; border: none; border-radius: 3px; cursor: pointer;">
            Guardar
          </button>
          <button type="button" *ngIf="clienteForm.idtcliente !== 0" (click)="limpiarFormulario()" style="margin-left: 5px; padding: 5px 10px;">
            Cancelar
          </button>
        </form>
      </fieldset>

      <!-- Tabla que muestra tus registros desde MySQL -->
      <table border="1" cellpadding="8" style="width: 100%; border-collapse: collapse; text-align: left; background-color: white;">
        <thead style="background-color: #f2f2f2;">
          <tr>
            <th>ID</th>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Dirección</th>
            <th>Teléfono</th>
            <th>numero_cuenta</th>
            <th>Acciones</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let cliente of listaClientes">
            <td>{{ cliente.idtcliente }}</td>
            <td>{{ cliente.nombre }}</td>
            <td>{{ cliente.apellido }}</td>
            <td>{{ cliente.direccion }}</td>
            <td>{{ cliente.telefono }}</td>
            <td>{{ cliente.numero_cuenta }}</td>
            <td>
              <button (click)="seleccionarParaEditar(cliente)" style="background-color: #ffc107; border: none; padding: 3px 8px; border-radius: 3px; cursor: pointer; margin-right: 5px;">Editar</button>
              <button (click)="eliminar(cliente.idtcliente)" style="background-color: #dc3545; color: white; border: none; padding: 3px 8px; border-radius: 3px; cursor: pointer;">Eliminar</button>
            </td>
          </tr>
          <tr *ngIf="listaClientes.length === 0">
            <td colspan="7" style="text-align: center; color: #777;">No hay clientes registrados o el backend de C# está apagado.</td>
          </tr>
        </tbody>
      </table>
    </div>
  `
})
export class App implements OnInit {
  listaClientes: any[] = [];
  
  clienteForm: any = {
    idtcliente: 0,
    nombre: '',
    apellido: '',
    direccion: '',
    telefono: '',
    numero_cuenta: null
  };

  constructor(private clienteService: ClienteService) { }

  ngOnInit(): void {
    this.obtenerTodos();
  }

  obtenerTodos() {
    this.clienteService.getClientes().subscribe({
      next: (data) => { this.listaClientes = data; },
      error: (err) => { console.error('Error al cargar clientes:', err); }
    });
  }

   guardar() {
    if (this.clienteForm.idtcliente === 0) {
      this.clienteService.insertarCliente(this.clienteForm).subscribe({
        next: () => {
          alert('¡Cliente insertado con éxito!');
          this.obtenerTodos();
          this.limpiarFormulario();
        },
        error: (err) => { console.error('Error al insertar:', err); }
      });
    } else {
      this.clienteService.modificarCliente(this.clienteForm).subscribe({
        next: () => {
          alert('¡Cliente modificado con éxito!');
          this.obtenerTodos(); // Fuerza la recarga de las columnas en pantalla
          this.limpiarFormulario();
        },
        error: (err) => { 
          alert('Error al modificar. Revisa la API en C#.'); 
          console.error('Detalle del error:', err); 
        }
      });
    }
  }
  seleccionarParaEditar(cliente: any) {
    this.clienteForm = { ...cliente };
  }

  eliminar(id: number) {
    if (confirm('¿Estás seguro de eliminar este cliente?')) {
      this.clienteService.eliminarCliente(id).subscribe(() => {
        this.obtenerTodos();
      });
    }
  }

  limpiarFormulario() {
    this.clienteForm = { idtcliente: 0, nombre: '', apellido: '', direccion: '', telefono: '', numero_cuenta: null };
  }
}