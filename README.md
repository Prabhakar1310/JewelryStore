# Project Detail

This Project is for Jewelry Store. It will Print total amount value into File , Paper, or Screen. 

# Project Setup
- clone this repo.
- Set `PathToStoreFile` properties in `JewelryStore/Resource.resx` . Default value is `\TotlaPrice` and file will be stored in `~/TotalPrice` Folder.
-  Set `DataFileLocation` Properties in `JewelryStore.Dal/Resource.resx` . Defualt value is `\CustomerData.xml` that means `customerData.xml` file is availble in `JewelryStore.Dal` folder
- Set `Allowedcategories` properties in `JewelryStore.BL/Resource.resx` . Defualt Value is `Privileged`. For allowing both `Privileged` and `Regular` user, set this property to `Privileged,Regular`. This is a case senesetive field.
- Set `Discount` Property in `JewelryStore.BL/Resource.resx`. Defualt value is `2` . This field represent discount offered to customer and accept any decimal value.
- Below Login can be used:
  -  UserName: Prabhakar , Password: PassWord
  -  UserName: Singh , Password : Password
