﻿Imports System.Data.SqlClient
Public Class fcategoria
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_categoria") With {
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
    Public Function insertar(ByVal dts As vcategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gnombre_categoria)

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
    Public Function editar(ByVal dts As vcategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcategoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gnombre_categoria)

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
    Public Function eliminar(ByVal dts As vcategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcategoria", SqlDbType.NVarChar, 50).Value = dts.gidcategoria
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