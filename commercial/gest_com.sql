-- ============================================================
--   Nom de la base   :  GESTION_COMMERCIALE                   
--   Nom de SGBD      :  ORACLE Version 7.0                    
--   Date de cr‚ation :  04/11/1995  15:51                     
-- ============================================================

-- ============================================================
--   Nom de la base   :  GESTION_COMMERCIALE                   
-- ============================================================
/* create database GESTION_COMMERCIALE; */

-- ============================================================
--   On efface les tables dans l'ordre inverse de la création  
-- ============================================================
 drop table DETAIL_CDE ;
 drop table COMMANDES ;
 drop table VENDEUR ;
  drop table CLIENTEL ;
  drop table COMPOSE;
  drop table ARTICLES ;


-- ============================================================
--   Table : VENDEUR                                           
-- ============================================================
create table VENDEUR
(
    NO_VENDEUR                      CHAR(6)                not null,
    NO_VEND_CHEF_EQ                 CHAR(6)                not null,
    NOM_VEND                        CHAR(15)               not null,
    PRENOM_VEND                     CHAR(10)               not null,
    DATE_EMBAU                      DATE                   not null,
    VILLE_VEND                      CHAR(15)               not null,
    SALAIRE_VEND                    DECIMAL(8,2)           not null,
    COMMISSION                      DECIMAL(6,2)           not null,
    constraint pk_vendeur primary key (NO_VENDEUR)
);


-- ============================================================
--   Table : ARTICLES                                          
-- ============================================================
create table ARTICLES
(
    NO_ARTICLE                      CHAR(6)                not null,
    LIB_ARTICLE                     CHAR(30)               not null,
    QTE_DISPO                       INTEGER                not null,
    VILLE_ART                       CHAR(15)               not null,
    PRIX_ART                        DECIMAL(8,2)           not null,
    INTERROMPU                      CHAR(1)                not null,
    constraint pk_articles primary key (NO_ARTICLE)
);

-- ============================================================
--   Table : CLIENTEL                                          
-- ============================================================
create table CLIENTEL
(
    NO_CLIENT                       CHAR(6)                not null,
    SOCIETE                         CHAR(25)               not null,
    NOM_CL                          CHAR(15)               not null,
    PRENOM_CL                       CHAR(10)               not null,
    ADRESSE_CL                      CHAR(25)               not null,
    VILLE_CL                        CHAR(15)               not null,
    CODE_POST_CL                    CHAR(5)                not null,
    constraint pk_clientel primary key (NO_CLIENT)
);

-- ============================================================
--   Table : COMMANDES                                         
-- ============================================================
create table COMMANDES
(
    NO_COMMAND                      CHAR(6)                not null,
    NO_VENDEUR                      CHAR(6)                not null,
    NO_CLIENT                       CHAR(6)                not null,
    DATE_CDE                        DATE                   not null,
    FACTURE                         CHAR(1)                not null,
    constraint pk_commandes primary key (NO_COMMAND)
);


-- ============================================================
--   Table : DETAIL_CDE                                        
-- ============================================================
create table DETAIL_CDE
(
    NO_COMMAND                      CHAR(6)                not null,
    NO_ARTICLE                      CHAR(6)                not null,
    QTE_CDEE                        INTEGER                        ,
    LIVREE                          CHAR(1)                        ,
    constraint pk_detail_cde primary key (NO_COMMAND, NO_ARTICLE)
);

-- ============================================================
--   Table : COMPOSE                                           
-- ============================================================
create table COMPOSE
(
    NO_COMPOSE                      CHAR(6)                not null,
    NO_COMPOSANT                    CHAR(6)                not null,
    QTE_COMPOSANT                   INTEGER                        ,
    constraint pk_compose primary key (NO_COMPOSE, NO_COMPOSANT)
);

alter table VENDEUR
    add constraint fk1_vendeur foreign key (NO_VEND_CHEF_EQ)
       references VENDEUR (NO_VENDEUR);

alter table COMMANDES
    add constraint fk1_commandes foreign key (NO_VENDEUR)
       references VENDEUR (NO_VENDEUR);

alter table COMMANDES
    add constraint fk2_commandes foreign key (NO_CLIENT)
       references CLIENTEL (NO_CLIENT);

alter table DETAIL_CDE
    add constraint fk1_detail_cde foreign key (NO_COMMAND)
       references COMMANDES (NO_COMMAND);

alter table DETAIL_CDE
    add constraint fk2_detail_cde foreign key (NO_ARTICLE)
       references ARTICLES (NO_ARTICLE);

alter table COMPOSE
    add constraint fk1_compose foreign key (NO_COMPOSE)
       references ARTICLES (NO_ARTICLE);

alter table COMPOSE
    add constraint fk2_compose foreign key (NO_COMPOSANT)
       references ARTICLES (NO_ARTICLE);

