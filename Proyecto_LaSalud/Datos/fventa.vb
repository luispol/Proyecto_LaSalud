Imports System.Data.SqlClient

Public Class fventa
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_venta") With {
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
    Public Function insertar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@forma_pago", dts.gforma_pago)

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
    Public Function editar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@no_factura", dts.gno_factura)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@forma_pago", dts.gforma_pago)
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
    Public Function eliminar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@no_factura", SqlDbType.NVarChar, 50).Value = dts.gno_factura
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



End Class
