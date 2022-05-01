function AddDataTable(table, searching, firstTime) {
    
      tt =   $(table).DataTable({
          "searching": searching,
          retrieve: true,
            dom: 'Bfrtip',
            buttons: [
                'excel', 'pdf'
            ]
        });
   
    

}