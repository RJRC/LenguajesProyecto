<%@ Page Title="" Language="C#" MasterPageFile="~/IndexMasterPage.Master" AutoEventWireup="true" CodeBehind="CRUDPlates.aspx.cs" Inherits="ProyectoLenguajes.CRUDPlates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentTittle" runat="server">
    Administrar Platos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <div class="col-md-3"> </div>

  <div class="col-md-6">

     <div class="container-fluid bg">  
    
         <form class="form-conatiner">
         </form>
        <h1 style="text-align:center">Administrar Platos</h1>
         <form class="form-conatiner">
        <!--Listar Platos -->
        <div class="">
        <h3 style="text-align:center">Lista de Platos</h3>
            <asp:GridView ID="GridViewPlates" class="gridViewPlates" runat="server"></asp:GridView>
        </div>
        </form>
         
        
         <form class="form-conatiner">
         <!--Modificar-->
         <div class="">
                <h3 style="text-align:center">Modificar Plato</h3>
              
              <div>
                  <label for="exampleInputID">Ingrese un ID</label>
                  <asp:TextBox ID="TextBox5" class="form-control" runat="server" type="number" placeholder="Codigo" Width="178px"></asp:TextBox>
                  <asp:Button ID="Button2" class="btn btn-success btn-block"  runat="server" Width="178px" Text="Cargar Plato" />
                  <label for="exampleInputName"></label>
                 </div>
             
              <div class="form-group">
                    <label for="exampleInputName">Nombre</label>
                    <asp:TextBox ID="TextBox1" type="text" placeholder="Nombre" class="form-control" runat="server" required=""></asp:TextBox>
                 </div>
      

              <div class="form-group">
                <label for="exampleInputDescription">Descripcion</label>
                <asp:TextBox ID="TextBox2"  placeholder="Descripcion" class="form-control" runat="server" ></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="exampleInputPrice">Precio</label>
                <asp:TextBox ID="TextBox3"  type="number" placeholder="Precio" class="form-control" runat="server" required=""></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="exampleInputPhoto">Fotografia</label>
                <asp:TextBox ID="TextBox4"  placeholder="Fotografia" class="form-control" runat="server" required=""></asp:TextBox>
              </div>

                <asp:Button ID="Button1"  class="btn btn-success btn-block" runat="server" Text="Modificar Plato" />

          </div>
         
         </form>
        <!--Modificar Fin-->

        <!--Agregar --> 
         <form class="form-conatiner">
      
        <div class="">
        <h3 style="text-align:center">Agregar Platos</h3>
        <div class="form-group">
        <label for="exampleInputName">Nombre</label>
        <asp:TextBox ID="TextBoxName" type="text" placeholder="Nombre" class="form-control" runat="server" required=""></asp:TextBox>

      </div>

        <div class="form-group">
        <label for="exampleInputDescription">Descripcion</label>
        <asp:TextBox ID="TextBoxFullDescription"  placeholder="Descripcion" class="form-control" runat="server" ></asp:TextBox>
      </div>

        <div class="form-group">
        <label for="exampleInputPrice">Precio</label>
        <asp:TextBox ID="TextBoxPrice"  type="number" placeholder="Precio" class="form-control" runat="server" required=""></asp:TextBox>
      </div>

        <div class="form-group">
        <label for="exampleInputPhoto">Fotografia</label>
        <asp:TextBox ID="TextBoxPhoto"  placeholder="Fotografia" class="form-control" runat="server" required=""></asp:TextBox>
      </div>

        <asp:Button ID="ButtonADDPlate"  class="btn btn-success btn-block" runat="server" Text="Agregar Plato"  />
        </div>
        
         </form>
         <!--Agregar Fin -->
         <!--Eliminar-->
         <form class="form-conatiner">
         
         <div class="">
                <h3 style="text-align:center">Eliminar Plato</h3>
              
              <div>
                  <label for="exampleInputID">Ingrese un ID</label>
                  <asp:TextBox ID="TextBox6" class="form-control" runat="server" placeholder="Codigo" Width="178px"></asp:TextBox>
                  <asp:Button ID="Button3" class="btn btn-success btn-block"  runat="server" Width="178px" Text="Cargar Plato" />
                  <label for="exampleInputName"></label>
                 </div>
             
              <div class="form-group">
                    <label for="exampleInputName">Nombre</label>
                    <asp:TextBox ID="TextBox7" type="text" placeholder="Nombre" class="form-control" runat="server" required="" ReadOnly="True"></asp:TextBox>
                 </div>
      

              <div class="form-group">
                <label for="exampleInputDescription">Descripcion</label>
                <asp:TextBox ID="TextBox8"  placeholder="Descripcion" class="form-control" runat="server" ReadOnly="True" ></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="exampleInputPrice">Precio</label>
                <asp:TextBox ID="TextBox9"  type="number" placeholder="Precio" class="form-control" runat="server" ReadOnly="True" required=""></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="exampleInputPhoto">Fotografia</label>
                <asp:TextBox ID="TextBox10"  placeholder="Fotografia" class="form-control" runat="server" required="" ReadOnly="True"></asp:TextBox>
              </div>

                <asp:Button ID="ButtonDeleteByID"  class="btn btn-success btn-block" runat="server" Text="Modificar Plato" />

          </div>
         
         </form>
         <!--Eliminar Fin-->
   </div>

  </div> 


</asp:Content>
