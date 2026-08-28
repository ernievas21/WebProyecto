import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  // Esta es la URL de tu API de C# que probamos con éxito en el navegador
  private apiUrl = 'https://localhost:44338/api/clientes';

  constructor(private http: HttpClient) { }

  // 1. OBTENER TODOS LOS CLIENTES (GET)
  getClientes(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  // 2. INSERTAR NUEVO CLIENTE (POST)
  insertarCliente(cliente: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, cliente);
  }

  // 3. MODIFICAR CLIENTE (PUT)
  modificarCliente(cliente: any): Observable<any> {
    return this.http.put<any>(this.apiUrl, cliente);
  }

  // 4. ELIMINAR CLIENTE POR ID (DELETE)
  eliminarCliente(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/${id}`);
  }
}
