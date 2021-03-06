﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fashion.Code.DAL
{
    public class SpecialConsultAnswerClothes_dal
    {
        /// <summary>
        /// 将专家对特定咨询的接到的衣服购买链接存储到数据库
        /// </summary>
        /// <param name="specialConsultAnswer_Id">专家的解答的数据表的id</param>
        /// <param name="selectClothUrlDic">衣服购买链接的键值对</param>
        /// <returns></returns>
        public int InsertConsultAnswerClothes(int specialConsultAnswer_Id, Dictionary<string, string> selectClothUrlDic)
        {
            Dictionary<string, string>.KeyCollection clothTypeKeys = selectClothUrlDic.Keys;
            string sqlStr = "";
            foreach (string clothType in clothTypeKeys)
            {
                sqlStr = sqlStr + @"insert tb_SpecialConsultAnswerClothes (SpecialConsultAnswerClothes_AnswerId, 
                                                                                                                  SpecialConsultAnswerClothes_ClotheType, 
									                                                                              SpecialConsultAnswerClothes_ClotheUrl)
							                                                                          values ("+specialConsultAnswer_Id+",'"+clothType+"','"+selectClothUrlDic[clothType]+"')";
            }
            return SqlHelper.ExecuteNonquery(sqlStr);

        }
    }
}