﻿#ExternalChecksum("..\..\Window3.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","EB402B2F1E03B561B8C33B2092CF4062")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.6407
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes


'''<summary>
'''Window3
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Window3
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\Window3.xaml",16)
    Friend WithEvents Image1 As System.Windows.Controls.Image
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Window3.xaml",17)
    Friend WithEvents Label1 As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Window3.xaml",18)
    Friend WithEvents Button3 As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Madinaty1;component/window3.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Window3.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.Image1 = CType(target,System.Windows.Controls.Image)
            Return
        End If
        If (connectionId = 2) Then
            Me.Label1 = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 3) Then
            Me.Button3 = CType(target,System.Windows.Controls.Button)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

