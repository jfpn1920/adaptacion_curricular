Imports System
Module adaptacion_curricular
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim estudiantes(9) As String
        Dim grados(9) As String
        Dim areas(9) As String
        Dim necesidades(9) As String
        Dim adaptaciones(9) As String
        Dim estrategias(9) As String
        Dim responsables(9) As String
        Dim fechas(9) As String
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '---------------------------------------------//
        '--|menu_principal_de_adaptacion_curricular|--//
        '---------------------------------------------//
        Do
            Console.WriteLine("menu principal de adaptacion curricular")
            Console.WriteLine("1) Registrar adaptacion")
            Console.WriteLine("2) Editar adaptacion")
            Console.WriteLine("3) Listar adaptaciones")
            Console.WriteLine("4) Buscar adaptacion")
            Console.WriteLine("5) Eliminar adaptacion")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '--------------------------//
                '--|registrar_adaptacion|--//
                '--------------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas adaptaciones.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de adaptacion curricular")
                        Console.Write("Estudiante: ")
                        estudiantes(cantidad) = Console.ReadLine()
                        Console.Write("Grado: ")
                        grados(cantidad) = Console.ReadLine()
                        Console.Write("Area: ")
                        areas(cantidad) = Console.ReadLine()
                        Console.Write("Necesidad: ")
                        necesidades(cantidad) = Console.ReadLine()
                        Console.Write("Adaptacion: ")
                        adaptaciones(cantidad) = Console.ReadLine()
                        Console.Write("Estrategia: ")
                        estrategias(cantidad) = Console.ReadLine()
                        Console.Write("Responsable: ")
                        responsables(cantidad) = Console.ReadLine()
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Adaptacion curricular registrada correctamente.")
                    End If
                '-----------------------//
                '--|editar_adaptacion|--//
                '-----------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen adaptaciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Estudiante: " & estudiantes(i) & " | Grado: " & grados(i) & " | Area: " & areas(i) & " | Necesidad: " & necesidades(i) & " | Adaptacion: " & adaptaciones(i) & " | Estrategia: " & estrategias(i) & " | Responsable: " & responsables(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la adaptacion a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo estudiante: ")
                            estudiantes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo grado: ")
                            grados(posicion) = Console.ReadLine()
                            Console.Write("Nueva area: ")
                            areas(posicion) = Console.ReadLine()
                            Console.Write("Nueva necesidad: ")
                            necesidades(posicion) = Console.ReadLine()
                            Console.Write("Nueva adaptacion: ")
                            adaptaciones(posicion) = Console.ReadLine()
                            Console.Write("Nueva estrategia: ")
                            estrategias(posicion) = Console.ReadLine()
                            Console.Write("Nuevo responsable: ")
                            responsables(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.WriteLine("Adaptacion curricular actualizada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------//
                '--|listar_adaptaciones|--//
                '-------------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen adaptaciones registradas.")
                    Else
                        Console.WriteLine("lista de adaptaciones curriculares")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Estudiante: " & estudiantes(i) & " | Grado: " & grados(i) & " | Area: " & areas(i) & " | Necesidad: " & necesidades(i) & " | Adaptacion: " & adaptaciones(i) & " | Estrategia: " & estrategias(i) & " | Responsable: " & responsables(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '-----------------------//
                '--|buscar_adaptacion|--//
                '-----------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen adaptaciones registradas.")
                    Else
                        Console.Write("Ingrese el ID de la adaptacion a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("adaptacion encontrada")
                            Console.WriteLine("ID: " & ids(posicion) & " | Estudiante: " & estudiantes(posicion) & " | Grado: " & grados(posicion) & " | Area: " & areas(posicion) & " | Necesidad: " & necesidades(posicion) & " | Adaptacion: " & adaptaciones(posicion) & " | Estrategia: " & estrategias(posicion) & " | Responsable: " & responsables(posicion) & " | Fecha: " & fechas(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------//
                '--|eliminar_adaptacion|--//
                '-------------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen adaptaciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Estudiante: " & estudiantes(i) & " | Grado: " & grados(i) & " | Area: " & areas(i) & " | Necesidad: " & necesidades(i) & " | Adaptacion: " & adaptaciones(i) & " | Estrategia: " & estrategias(i) & " | Responsable: " & responsables(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la adaptacion a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                estudiantes(i) = estudiantes(i + 1)
                                grados(i) = grados(i + 1)
                                areas(i) = areas(i + 1)
                                necesidades(i) = necesidades(i + 1)
                                adaptaciones(i) = adaptaciones(i + 1)
                                estrategias(i) = estrategias(i + 1)
                                responsables(i) = responsables(i + 1)
                                fechas(i) = fechas(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Adaptacion curricular eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen adaptaciones registradas.")
                    Else
                        Dim pendientes As Integer = 0
                        Dim enProceso As Integer = 0
                        Dim aplicadas As Integer = 0
                        Dim evaluadas As Integer = 0
                        Dim finalizadas As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i).ToLower() = "pendiente" Then
                                pendientes += 1
                            ElseIf estados(i).ToLower() = "en proceso" Then
                                enProceso += 1
                            ElseIf estados(i).ToLower() = "aplicada" Then
                                aplicadas += 1
                            ElseIf estados(i).ToLower() = "evaluada" Then
                                evaluadas += 1
                            ElseIf estados(i).ToLower() = "finalizada" Then
                                finalizadas += 1
                            End If
                        Next
                        Console.WriteLine("resumen de adaptacion curricular")
                        Console.WriteLine("Adaptaciones registradas: " & cantidad & " | Pendientes: " & pendientes & " | En proceso: " & enProceso & " | Aplicadas: " & aplicadas & " | Evaluadas: " & evaluadas & " | Finalizadas: " & finalizadas)
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Adaptacion Curricular.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module