﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RecBinTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RecBinTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.0")]
    [RepositoryFolder("280acea8-7a7d-4acf-8384-f2b14b36291c")]
    public partial class RecBinTestRepository : RepoGenBaseFolder
    {
        static RecBinTestRepository instance = new RecBinTestRepository();
        RecBinTestRepositoryFolders.ExplorerAppFolder _explorer;
        RecBinTestRepositoryFolders.КорзинаAppFolder _корзина;
        RecBinTestRepositoryFolders.УдалитьФайлAppFolder _удалитьфайл;

        /// <summary>
        /// Gets the singleton class instance representing the RecBinTestRepository element repository.
        /// </summary>
        [RepositoryFolder("280acea8-7a7d-4acf-8384-f2b14b36291c")]
        public static RecBinTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RecBinTestRepository() 
            : base("RecBinTestRepository", "/", null, 0, false, "280acea8-7a7d-4acf-8384-f2b14b36291c", ".\\RepositoryImages\\RecBinTestRepository280acea8.rximgres")
        {
            _explorer = new RecBinTestRepositoryFolders.ExplorerAppFolder(this);
            _корзина = new RecBinTestRepositoryFolders.КорзинаAppFolder(this);
            _удалитьфайл = new RecBinTestRepositoryFolders.УдалитьФайлAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("280acea8-7a7d-4acf-8384-f2b14b36291c")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("caf55ebd-2ec1-4f6e-a02a-3bfbebb97223")]
        public virtual RecBinTestRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The Корзина folder.
        /// </summary>
        [RepositoryFolder("31ffcb41-3bc4-4d5f-959b-9f7fd86cc68a")]
        public virtual RecBinTestRepositoryFolders.КорзинаAppFolder Корзина
        {
            get { return _корзина; }
        }

        /// <summary>
        /// The УдалитьФайл folder.
        /// </summary>
        [RepositoryFolder("2393bab1-7e79-4036-bec5-38c8fdb5d740")]
        public virtual RecBinTestRepositoryFolders.УдалитьФайлAppFolder УдалитьФайл
        {
            get { return _удалитьфайл; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.0")]
    public partial class RecBinTestRepositoryFolders
    {
        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("caf55ebd-2ec1-4f6e-a02a-3bfbebb97223")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _корзинаInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/desktop[@processname='explorer']", parentFolder, 30000, null, true, "caf55ebd-2ec1-4f6e-a02a-3bfbebb97223", "")
            {
                _корзинаInfo = new RepoItemInfo(this, "Корзина", "?/?/list[@controlid='1']/listitem[@text='Корзина']", 30000, null, "bdc78713-8f85-447b-8351-05ca8a707d50");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("caf55ebd-2ec1-4f6e-a02a-3bfbebb97223")]
            public virtual Ranorex.Desktop Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Desktop>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("caf55ebd-2ec1-4f6e-a02a-3bfbebb97223")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Корзина item.
            /// </summary>
            [RepositoryItem("bdc78713-8f85-447b-8351-05ca8a707d50")]
            public virtual Ranorex.ListItem Корзина
            {
                get
                {
                    return _корзинаInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Корзина item info.
            /// </summary>
            [RepositoryItemInfo("bdc78713-8f85-447b-8351-05ca8a707d50")]
            public virtual RepoItemInfo КорзинаInfo
            {
                get
                {
                    return _корзинаInfo;
                }
            }
        }

        /// <summary>
        /// The КорзинаAppFolder folder.
        /// </summary>
        [RepositoryFolder("31ffcb41-3bc4-4d5f-959b-9f7fd86cc68a")]
        public partial class КорзинаAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _button47c4c3b2499845cea2c035bd8a96cInfo;
            RepoItemInfo _закрытьInfo;
            RepoItemInfo _listitem0Info;

            /// <summary>
            /// Creates a new Корзина  folder.
            /// </summary>
            public КорзинаAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Корзина", "/form[@title='Корзина']", parentFolder, 30000, null, true, "31ffcb41-3bc4-4d5f-959b-9f7fd86cc68a", "")
            {
                _button47c4c3b2499845cea2c035bd8a96cInfo = new RepoItemInfo(this, "Button47C4C3B2499845CEA2C035BD8A96C", "element[@class='ShellTabWindowClass']//toolbar[@automationid='FolderBandModuleInner']/button[@automationid='{47C4C3B2-4998-45CE-A2C0-35BD8A96C726}']", 30000, null, "e88ee384-d7bd-42ba-93a4-348f3784a866");
                _закрытьInfo = new RepoItemInfo(this, "Закрыть", "?/?/button[@accessiblename='Закрыть']", 30000, null, "71695be0-0f1e-425f-a98b-aee409b93b20");
                _listitem0Info = new RepoItemInfo(this, "ListItem0", ".//element[@instance='1']/container[@caption='ShellView']/list[@name='Просмотр элементов']/listitem[@automationid='0']", 30000, null, "8d8fc8a6-b510-41f1-be9c-0b4b95823e1d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("31ffcb41-3bc4-4d5f-959b-9f7fd86cc68a")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("31ffcb41-3bc4-4d5f-959b-9f7fd86cc68a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Button47C4C3B2499845CEA2C035BD8A96C item.
            /// </summary>
            [RepositoryItem("e88ee384-d7bd-42ba-93a4-348f3784a866")]
            public virtual Ranorex.Button Button47C4C3B2499845CEA2C035BD8A96C
            {
                get
                {
                    return _button47c4c3b2499845cea2c035bd8a96cInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button47C4C3B2499845CEA2C035BD8A96C item info.
            /// </summary>
            [RepositoryItemInfo("e88ee384-d7bd-42ba-93a4-348f3784a866")]
            public virtual RepoItemInfo Button47C4C3B2499845CEA2C035BD8A96CInfo
            {
                get
                {
                    return _button47c4c3b2499845cea2c035bd8a96cInfo;
                }
            }

            /// <summary>
            /// The Закрыть item.
            /// </summary>
            [RepositoryItem("71695be0-0f1e-425f-a98b-aee409b93b20")]
            public virtual Ranorex.Button Закрыть
            {
                get
                {
                    return _закрытьInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Закрыть item info.
            /// </summary>
            [RepositoryItemInfo("71695be0-0f1e-425f-a98b-aee409b93b20")]
            public virtual RepoItemInfo ЗакрытьInfo
            {
                get
                {
                    return _закрытьInfo;
                }
            }

            /// <summary>
            /// The ListItem0 item.
            /// </summary>
            [RepositoryItem("8d8fc8a6-b510-41f1-be9c-0b4b95823e1d")]
            public virtual Ranorex.ListItem ListItem0
            {
                get
                {
                    return _listitem0Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItem0 item info.
            /// </summary>
            [RepositoryItemInfo("8d8fc8a6-b510-41f1-be9c-0b4b95823e1d")]
            public virtual RepoItemInfo ListItem0Info
            {
                get
                {
                    return _listitem0Info;
                }
            }
        }

        /// <summary>
        /// The УдалитьФайлAppFolder folder.
        /// </summary>
        [RepositoryFolder("2393bab1-7e79-4036-bec5-38c8fdb5d740")]
        public partial class УдалитьФайлAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonдаInfo;

            /// <summary>
            /// Creates a new УдалитьФайл  folder.
            /// </summary>
            public УдалитьФайлAppFolder(RepoGenBaseFolder parentFolder) :
                    base("УдалитьФайл", "/form[@title='Удалить файл']", parentFolder, 30000, null, true, "2393bab1-7e79-4036-bec5-38c8fdb5d740", "")
            {
                _buttonдаInfo = new RepoItemInfo(this, "ButtonДа", "button[@text='Д&а']", 30000, null, "44536358-c1f1-463c-a1a8-4e4321b60091");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2393bab1-7e79-4036-bec5-38c8fdb5d740")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2393bab1-7e79-4036-bec5-38c8fdb5d740")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonДа item.
            /// </summary>
            [RepositoryItem("44536358-c1f1-463c-a1a8-4e4321b60091")]
            public virtual Ranorex.Button ButtonДа
            {
                get
                {
                    return _buttonдаInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonДа item info.
            /// </summary>
            [RepositoryItemInfo("44536358-c1f1-463c-a1a8-4e4321b60091")]
            public virtual RepoItemInfo ButtonДаInfo
            {
                get
                {
                    return _buttonдаInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}