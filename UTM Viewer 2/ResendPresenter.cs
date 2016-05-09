using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM_Viewer_2
{
    
    class ResendPresenter
    {
        private readonly IFormResend _view;
        private readonly IModelResend _model;
        public ResendPresenter(IFormResend view, IModelResend model)
        {
            _view = view;
            _model = model;
            _view.resendTTN += _view_resendTTN;
            _view.getFormBRegInfo += _view_getFormBRegInfo;
        }

        private void _view_getFormBRegInfo(object sender, EventArgs e)
        {
            _view.outFormBRegInfo = _model.getFormBRegInfo(_view.ipUTM);
        }

        private void _view_resendTTN(object sender, EventArgs e)
        {
            string[] listTTN = _view.listTTNForResend.Split('\n');
            _view.outResendTTN = _model.resendTTN(_view.ipUTM, _view.fsRarId, listTTN);
            
        }
    }
}
