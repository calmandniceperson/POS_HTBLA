#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{

    //creates the main window
    ui->setupUi(this);

    connect(ui->categoryComboBox , SIGNAL(currentIndexChanged(int)),this,SLOT(handleProductSelectionChanged(int)));
    connect(ui->tabWidget, SIGNAL(currentChanged(int)), this, SLOT(handleTabClick(int)));

    ui->productList->hide();
    ui->orderButton->hide();

    //set text for the tabs at the top
    ui->tabWidget->setTabText(0, "Hardware");
    ui->tabWidget->setTabText(1, "Services");
    ui->tabWidget->setTabText(2, "Configure");
    ui->tabWidget->setTabText(3, "Shopping cart");

    //add items to the category selection dropdown menu
    ui->categoryComboBox->addItem("Graphics cards");
    ui->categoryComboBox->addItem("Storage");
    ui->categoryComboBox->addItem("Keyboards");


}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::handleProductSelectionChanged(int i){
    switch(i){
    case 0:
        ui->productList->clear();

        ui->productList->addItem("NVIDIA GeForce GTX 660 Ti");
        ui->productList->addItem("Intel HD Family 4000");

        ui->productList->show();
        break;
    case 1:
        ui->productList->clear();

        ui->productList->addItem("Samsung 840 EVO PRO 265GB");
        ui->productList->addItem("Seagate S50 500GB");

        ui->productList->show();
        break;
    case 2:
        ui->productList->clear();

        ui->productList->addItem("Steelseries 6Gv2");
        ui->productList->addItem("Microsoft Sidewinder");

        ui->productList->show();
        break;
    }
}

void MainWindow::handleTabClick(int i){
    switch(i){
    case 0:
        ui->orderButton->show();
        break;
    case 1:
        ui->orderButton->hide();
        break;
    case 2:
        ui->orderButton->show();
        break;
    case 3:
        ui->orderButton->show();
        break;
    }
}
