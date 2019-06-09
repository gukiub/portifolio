<?php 
    

    include_once 'dbconfig.php';
    include_once 'login/verifica_login.php';
    include_once 'login/redirect.php';
    include_once 'header.php';
?>

<div class="clearfix"></div><br />


<div class="container">
    <a href="adicionar.php" class="btn btn-primary btn-info"><i class="fa fa-plus-square"></i> &nbsp; Add Contato</a><br><br>
</div>

<div class="container">
    <table class='table table-bordered table-responsive'>
        <tr>
            <th>#</th>
            <th>Nome</th>
            <th>Número</th>
            <th>Email</th>
            <th colspan="2" style="text-align:center;">Acões</th>
        </tr>
        <?php 
            $query = "SELECT * FROM contatos";       
            $records_per_page=3;
            $newquery = $crud->paging($query,$records_per_page);
            $crud->viewEditar($newquery); 
         ?>
        <tr>
            <td colspan="7" style="text-align:center">
                <div class="pagination">
                    <?php $crud->paginglink($query,$records_per_page); ?>
                </div>
            </td>
        </tr>
    </table>


</div>

</div> <!-- /container -->

<?php include_once 'footer.php'; ?>
