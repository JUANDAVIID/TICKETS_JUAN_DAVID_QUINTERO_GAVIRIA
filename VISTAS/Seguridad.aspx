<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Seguridad.aspx.cs" Inherits="VISTAS.FrmSeguridad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--referencias-->
           <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />    
    
    <style type="text/css">
        .auto-style1 {
            position: relative;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-direction: column; 
            flex-direction: column;
            min-width: 0;
            word-wrap: break-word;
            background-color: #fff;
            background-clip: border-box;
            border-radius: .25rem;
            left: 0px;
            top: 0px;
            height: 120px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
            <div class="col-sm-12">
               <div class="auto-style1">
                  <div class="auto-style2">
                    Mantenedor Roles
                  </div>
                  <div class="card-body">
                        <div class="row">
                            <div class="col-sm-2">
                                <button id="btnNuevoRol" type="button" class="btn btn-sm btn-success">Nuevo</button>
                            </div>
                        </div>
                      <hr />
                        <div class="row mt-3">
                            <div class="col-sm-12">
                                <table id="tbrol" class="table table-striped table-bordered nowrap" style="width:100%">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Descripcion</th>
                                            <th>Estado</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                  </div>
                  <div class="card-footer">
                  </div>
                </div>
            </div>
    </div>
        <!-- Modal -->
    <div class="modal fade" id="modalrol" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
      <div class="modal-dialog" role="document">
      <%--<div class="modal-dialog modal-dialog-centered" role="document">--%>
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Rol</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <form>
              <input id="txtIdRol" class="model" name="IdRol" value="0" type="hidden" />
              <div class="form-group">
                <label for="txtDescripcion" class="col-form-label">Descripcion:</label>
                <input type="text" class="form-control form-control-sm model" id="txtDescripcion" name="Descripcion">
              </div>
              <div class="form-group">
                <label for="cboEstado" class="col-form-label">Activo:</label>
                <select class="form-control form-control-sm model" id="cboEstado" name="Activo">
                    <option value="1">Activo</option>
                    <option value="0">No Activo</option>
                </select>
              </div>
            </form>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-sm btn-secondary" data-dismiss="modal">Cerrar</button>
            <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary">Guardar Cambios</button>
          </div>
        </div>
      </div>
    </div>


 </asp:Content>
