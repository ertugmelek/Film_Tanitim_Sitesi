<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FilmSitesi.UI._default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Repeater ID="rptFilmler" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-12" style="height: 270px">
                            <div class="col-lg-4 col-md-6 col-sm-6 col-xs-12">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ResimPath") %>' Height="250px" Width="250px" />
                                <!--gerekli hücreyi yakalamamızı sağlar -->
                            </div>
                            <div class="col-lg-8 col-md-6 col-sm-6 col-xs-12">
                                <div>
                                    <h1>
                                        <%# Eval("FilmAdi") %>
                                    </h1>
                                    <!--gerekli hücreyi yakalamamızı sağlar -->
                                </div>
                                <div style="margin-top: 20px">

                                    <%# Eval("Aciklama") %>

                                    <!--gerekli hücreyi yakalamamızı sağlar -->
                                </div>
                                <div>
                                    <b>Yönetmen:</b><%# ((HashSet<FilmSitesi.Entity.Yonetmen>)Eval("Yonetmenler")).First().YonetmenAdi %>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</asp:Content>
