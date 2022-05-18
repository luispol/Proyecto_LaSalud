Imports System.Data.SqlClient
Public Class fdetalle_factura
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle_factura") With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = cnn
            }
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    'Funcion que recibe todos los datos de los objetos establecidos en vcliente 
    Public Function insertar(ByVal dts As vdetalle_factura) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_factura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@no_factura", dts.gno_factura)
            cmd.Parameters.AddWithValue("@idmedicamento", dts.gidmedicamento)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)

            'condicional si verifica si se ejectura la instruccion SQL
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    'FUNCION EDITAR
    Public Function editar(ByVal dts As vdetalle_factura) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_factura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@correlativo", dts.gcorrelativo)
            cmd.Parameters.AddWithValue("@no_factura", dts.gno_factura)
            cmd.Parameters.AddWithValue("@idmedicamento", dts.gidmedicamento)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)


            'condicional si verifica si se ejectura la instruccion SQL
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    'FUNCION ELIMINAR
    Public Function eliminar(ByVal dts As vdetalle_factura) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_factura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@correlativo", SqlDbType.NVarChar, 50).Value = dts.gcorrelativo
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    'FUNCION AUMENTAR STOCK
    Public Function aumentar_stock(ByVal dts As vdetalle_factura) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idmedicamento", dts.gidmedicamento)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)

            'condicional si verifica si se ejectura la instruccion SQL
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    'FUNCION DISMINUIR STOCK
    Public Function disminuir_stock(ByVal dts As vdetalle_factura) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idmedicamento", dts.gidmedicamento)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)

            'condicional si verifica si se ejectura la instruccion SQL
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function






End Class
