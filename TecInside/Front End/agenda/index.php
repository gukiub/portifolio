<?php 
    include_once 'admin/dbconfig.php';
    include_once 'header.php';
?>

<div class="clearfix"></div><br />

<?php include_once 'search.php'; ?>
<div class="container">
     <table class='table table-bordered table-responsive'>
         <tr>
             <th>#</th>
             <th>Nome</th>
             <th>Número</th>
             <th>Email</th>
         </tr>
         <?php
            $query = "SELECT * FROM contatos";       
            $records_per_page=3;
            $newquery = $crud->paging($query,$records_per_page);
            $crud->viewDados($newquery);
         ?>
        <tr>
            <td colspan="7" style="text-align:center;">
                <div class="pagination">
                <?php $crud->paginglink($query,$records_per_page); ?>
                </div>
            </td>
        </tr>
    </table>
           
</div>

</div> <!-- /container -->
<?php include_once 'footer.php'; ?>