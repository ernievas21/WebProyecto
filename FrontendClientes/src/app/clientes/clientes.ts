import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ClienteService } from '../cliente';

@Component({
  selector: 'app-clientes',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './clientes.html',
  styleUrl: './clientes.css'
})
export class ClientesComponent implements OnInit {
  listaClientes: any[] = [];
  
  // Objeto provisional para los formularios de insertar/modificar
  clienteForm: any = {
    idcliente: 0,
    nombre: '',
    apellido: '',
    telefono: '',
    direccion: ''
  };

  constructor(private clienteService: ClienteService) { }

  ngOnInit(): void {
    this.obtenerTodos();
  }

  // 1. Cargar la tabla
  obtenerTodos() {
    this.clienteService.getClientes().subscribe({
      next: (data) => { this.listaClientes = data; },
      error: (err) => { console.error('Error al cargar clientes:', err); }
    });
  }

  // 2. Acción del botón Guardar (Detecta si es nuevo o edición)
  guardar() {
    if (this.clienteForm.idcliente === 0) {
      this.clienteService.insertarCliente(this.clienteForm).subscribe(() => {
        this.obtenerTodos();
        this.limpiarFormulario();
      });
    } else {
      this.clienteService.modificarCliente(this.clienteForm).subscribe(() => {
        this.obtenerTodos();
        this.limpiarFormulario();
      });
    }
  }

  // 3. Pasar datos al formulario para editar
  seleccionarParaEditar(cliente: any) {
    this.clienteForm = { ...cliente };
  }

  // 4. Acción del botón Eliminar
  eliminar(id: number) {
    if (confirm('¿Estás seguro de eliminar este cliente?')) {
      this.clienteService.eliminarCliente(id).subscribe(() => {
        this.obtenerTodos();
      });
    }
  }

  limpiarFormulario() {
    this.clienteForm = { idtcliente: 0, nombre: '', apellido: '', direccion: '', telefono: '', edad: null };
  }
}