class Menu {
    constructor(menuName, menuPrice) {
        this.menuName = menuName;
        this.menuPrice = menuPrice;
    }
   
}
const menu1 = new Menu( "Big King" , 20);
const menu2 = new Menu( "Whooper" , 25);
const menu3 = new Menu("Big Chicken", 15);

var menus = new Array(menu1, menu2, menu3);



function GetMenu() {
    var tbody = document.getElementById("menuTable");
    tbody.innerHTML = " ";

    menus.forEach(function (menu, index) {
        tbody.innerHTML += `
                              <tr>
                                    <td>${menu.menuName}</td>
                                    <td>${menu.menuPrice}</td>
                                </tr>


                          `
    });
}

GetMenu();

const addButton = document.getElementById('submit');

addButton.addEventListener('click', function (e) {

    const menuName = document.getElementById('menuName').value;
    const menuPrice = document.getElementById('menuPrice').value;
    AddMenu(menuName, menuPrice);

    e.preventDefault();
})

function AddMenu(menuName, MenuPrice) {

    const menu = new Menu(menuName, menuPrice);
    menus.push(menu);
    GetMenu();
}