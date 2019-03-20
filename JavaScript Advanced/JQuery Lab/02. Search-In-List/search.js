/// <reference path="../typings/globals/jquery/index.d.ts" />

function search() {
   $(`#towns li`).css('font-weight', 'normal');

   let searchText = $('#searchText').val();

   let towns = $(`#towns li:contains(${searchText})`).css('font-weight', 'bold');

   let count = towns.length;
   $('#result').text(`${count} matches found.`);

}