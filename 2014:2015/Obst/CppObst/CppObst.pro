#-------------------------------------------------
#
# Project created by QtCreator 2014-12-11T21:55:50
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = CppObst
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    product.cpp \
    fruit.cpp \
    vegetable.cpp \
    fruit_product.cpp

HEADERS  += mainwindow.h \
    product.h \
    fruit.h \
    vegetable.h \
    fruit_product.h

FORMS    += mainwindow.ui
