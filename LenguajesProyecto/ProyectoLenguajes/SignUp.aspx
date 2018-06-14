<%@ Page Title="" Language="C#" MasterPageFile="~/IndexMasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ProyectoLenguajes.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentTittle" runat="server">
    Registrarse
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <div class="col-md-3">

   </div>

    <div class="col-md-6">

     <div class="container-fluid bg">  
         <form class="form-conatiner">
         </form>
    <form class="form-conatiner">
        <h1 style="text-align:center">Registrarse</h1>
      <div class="form-group">
        <label for="exampleInputEmail">Correo Electronico</label>
        <asp:TextBox ID="TextBoxEmail" type="email" placeholder="Correo Electronico" class="form-control" runat="server" required=""></asp:TextBox>

      </div>

      <div class="form-group">
        <label for="exampleInputEmail">Nombre Completo</label>
        <asp:TextBox ID="TextBoxFullName"  placeholder="Nombre Completo" class="form-control" runat="server" required=""></asp:TextBox>
      </div>

      <div class="form-group">
        <label for="exampleInputEmail">Direccion</label>
        <asp:TextBox ID="TextBoxAddress"  placeholder="Direccion" class="form-control" runat="server" required=""></asp:TextBox>
      </div>

      <div class="form-group">
        <label for="exampleInputPassword">Contraseña</label>
        <asp:TextBox ID="TextBoxPassword"  placeholder="Contraseña" class="form-control" runat="server" required=""></asp:TextBox>
      </div>

        <asp:Button ID="Button1"  class="btn btn-success btn-block" runat="server" Text="Enviar"  />

    </form>
    
   </div>
  </div> 
</asp:Content>
